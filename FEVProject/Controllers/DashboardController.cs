using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using FEVProject.Data;
using FEVProject.Models;

namespace FEVProject.Controllers
{
    public class DashboardController : Controller
    {
        private readonly FEVContext _context;

        public DashboardController(FEVContext context)
        {
            _context = context;
        }

        // GET: Dashboard
        public async Task<IActionResult> Index()
        {            
            return View(await _context.Events.ToListAsync());
        }
        public async Task<IActionResult> Profile()
        {
            var id = HttpContext.Session.GetString("id");
            return View(await _context.Users.FindAsync(id));
        }
        //GET: first time click Edit Profile button
        public async Task<IActionResult> EditProfile()
        {
            var id = HttpContext.Session.GetString("id");
            ViewBag.Action = "Edit";
            return View("Profile", await _context.Users.FindAsync(id));
        }
        //POST: update my profile
        [HttpPost]
        public async Task<IActionResult> EditProfile(EditProfileModel model)
        {
            var id = HttpContext.Session.GetString("id");
            var user = await _context.Users.FindAsync(id);
            if (!ModelState.IsValid)
            {
                ViewBag.Action = "Edit";
                return View("Profile", user);
            }
            else if (user != null)
            {
                try
                {
                    user.fullName = model.fullName;
                    user.email = model.email;
                    user.phone = model.phone;
                    user.birthdate = model.birthdate;
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                    return View("Profile", user);
                }
                catch
                {

                }
            }
            return View("Profile", user);
        }
        //GET: first time click Change Password button
        public async Task<IActionResult> ChangePass()
        {
            var id = HttpContext.Session.GetString("id");
            ViewBag.Action = "ChangePass";
            return View("Profile", await _context.Users.FindAsync(id));
        }
        //POST: update password
        [HttpPost]
        public async Task<IActionResult> ChangePass(string pass, string newpass, string repass)
        {
            var id = HttpContext.Session.GetString("id");
            var user = await _context.Users.FindAsync(id);
            if (pass == null || newpass == null || repass == null)
            {
                ModelState.AddModelError("pass", "You must fill all field");
                ViewBag.Action = "ChangePass";
                return View("Profile", user);
            }
            if (user != null)
            {
                if (!pass.Equals(user.password))
                {
                    ModelState.AddModelError("pass", "Wrong current password");
                    ViewBag.Action = "ChangePass";
                    return View("Profile", user);
                }
                else if (!newpass.Equals(repass))
                {
                    ModelState.AddModelError("pass", "Re-password doesn't match");
                    ViewBag.Action = "ChangePass";
                    return View("Profile", user);
                }
                else
                {
                    try
                    {
                        user.password = newpass;
                        _context.Update(user);
                        await _context.SaveChangesAsync();
                        return View("Profile", user);
                    }
                    catch
                    {

                    }
                }
            }
            return View("Profile", user);
        }
        // GET: Events/Details/5
        public async Task<IActionResult> EventDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.eventId == id);
            if (@event == null)
            {
                return NotFound();
            }
            EventDetailViewModel viewModel = new EventDetailViewModel();
            viewModel.Users = new List<User>();
            // Get team list in event
            var teamList = _context.Teams.Where(m => m.eventId == id).ToList();            
            foreach (var t in teamList)
            {
                // Get team members in each team
                t.TeamMembers = _context.TeamMembers.Where(m => m.teamId == t.teamId).ToList();
                foreach(var mem in t.TeamMembers)
                {
                    // Bind User instance
                    mem.User = _context.Users.Find(mem.username);
                    // Add into all member in event
                    viewModel.Users.Add(mem.User);
                }
                t.Tasks = _context.Tasks.Where(m => m.teamId == t.teamId).ToList();
            }                        
            viewModel.Event = @event;
            viewModel.Teams = teamList;
            // Remove duplicate User
            viewModel.Users = viewModel.Users.Distinct().ToList();
            ViewData["Me"] = HttpContext.Session.GetString("id");
            return View(viewModel);
        }
        public async Task<IActionResult> ViewProfile(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.username.Equals(id));
            if (user == null)
            {
                return NotFound();
            }
            ViewBag.OtherInf = "Yes";
            return View("Profile", user);
        }
        public async Task<IActionResult> DeleteMember(string id, string option, int pointer)
        {
            if(option.Equals("All"))
            {
                var teamList = _context.Teams.Where(m => m.eventId == pointer).ToList();
                foreach(var p in teamList)
                {
                    var teamMems = _context.TeamMembers.Where(m => m.teamId == p.teamId).ToList();
                    foreach(var m in teamMems)
                    {
                        if(m.username == id)
                        {
                            _context.TeamMembers.Remove(m);
                            break;
                        }
                    }                    
                    _context.SaveChanges();
                }
                return RedirectToAction("EventDetail", new { id = pointer });
            }
            if (option.Equals("Team"))
            {
                var mem = _context.TeamMembers.ToList().Find(m => m.teamId == pointer && m.username == id);
                _context.TeamMembers.Remove(mem);
                _context.SaveChanges();
                var eventId = _context.Teams.ToList().Find(m => m.teamId == pointer).eventId;
                return RedirectToAction("EventDetail", new { id = eventId });
            }
            return View("Index",await _context.Events.ToListAsync());
        }
        public async Task<IActionResult> AddMemToTeam(int id, string username)
        {
            if(username == null)
            {
                int eventId = _context.Teams.Find(id).eventId;
                var teamMem = _context.TeamMembers.Where(m => m.teamId == id).ToList();
                var users = _context.Users.ToList();
                foreach (var m in teamMem)
                {
                    var u = users.FirstOrDefault(a => a.username.Equals(m.username));
                    if(u != null)
                    {
                        users.Remove(u);
                    }
                }
                return View(new Tuple<ICollection<User>, int, int>(users,id, eventId));
            } else
            {
                int eventId = _context.Teams.Find(id).eventId;
                var newMem = new TeamMember();
                newMem.teamId = id;
                newMem.username = username;
                newMem.role = 1;
                _context.TeamMembers.Add(newMem);
                _context.SaveChanges();
                var teamMem = _context.TeamMembers.Where(m => m.teamId == id).ToList();
                var users = _context.Users.ToList();
                foreach (var m in teamMem)
                {
                    var u = users.FirstOrDefault(a => a.username.Equals(m.username));
                    if (u != null)
                    {
                        users.Remove(u);
                    }
                }
                return View(new Tuple<ICollection<User>, int, int>(users, id, eventId));
            }
            
        }
        public async Task<IActionResult> AddTask(int id, string receiver, string description)
        {
            if (receiver == null)
            {
                var team = _context.Teams.Find(id);
                var teamMem = _context.TeamMembers.Where(m => m.teamId == id).ToList();                                
                return View(new Tuple<ICollection<TeamMember>, int>(teamMem, team.eventId));           
            }
            else if(receiver.Equals("not choose"))
            {
                ModelState.AddModelError("receiver", "Please choose a receiver");
                var team = _context.Teams.Find(id);
                var teamMem = _context.TeamMembers.Where(m => m.teamId == id).ToList();
                return View(new Tuple<ICollection<TeamMember>, int>(teamMem, team.eventId));
            } else if(description == null)
            {
                ModelState.AddModelError("description", "Please enter description");
                var team = _context.Teams.Find(id);
                var teamMem = _context.TeamMembers.Where(m => m.teamId == id).ToList();
                return View(new Tuple<ICollection<TeamMember>, int>(teamMem, team.eventId));
            } else
            {
                var task = new FEVProject.Models.Task();
                task.teamId = id;
                task.owner = HttpContext.Session.GetString("id");
                task.receiver = receiver;
                task.description = description;
                task.startDate = DateTime.Today.ToString("yyyy-MM-dd");
                _context.Tasks.Add(task);
                _context.SaveChanges();
                var eventId = _context.Teams.Find(id).eventId;
                return RedirectToAction("EventDetail", new { id = eventId });
            }            
        }
        public async Task<IActionResult> DeleteTask(int id, string eventId)
        {
            var task = _context.Tasks.Find(id);
            _context.Tasks.Remove(task);
            _context.SaveChanges();
            return RedirectToAction("EventDetail", new { id = eventId });
        }
        public async Task<IActionResult> AcceptTask(int id, string eventId)
        {
            var task = _context.Tasks.Find(id);
            if(!task.done)
            {
                if(task.accepted)
                {
                    task.accepted = false;
                } else
                {
                    task.accepted = true;
                }
            }
            _context.Tasks.Update(task);
            _context.SaveChanges();
            return RedirectToAction("EventDetail", new { id = eventId });
        }
        public async Task<IActionResult> DoneTask(int id, string eventId)
        {
            var task = _context.Tasks.Find(id);
            if (task.done)
            {
                task.endDate = null;
                task.done = false;
            }
            else
            {
                task.endDate = DateTime.Today.ToString("yyyy-MM-dd");
                task.done = true;
            }            
            _context.Tasks.Update(task);
            _context.SaveChanges();
            return RedirectToAction("EventDetail", new { id = eventId });
        }
        public async Task<IActionResult> EditTask(int id, int eventId, string receiver, string description)
        {
            var task = _context.Tasks.Find(id);
            var teamMem = _context.TeamMembers.Where(m => m.teamId == task.teamId).ToList();
            if (receiver == null && description == null)
            {                
                return View(new Tuple<ICollection<TeamMember>, int, FEVProject.Models.Task>(teamMem, eventId, task));
            } else
            {
                if (receiver.Equals("not choose"))
                {
                    ModelState.AddModelError("receiver", "Please choose a receiver");                    
                    return View(new Tuple<ICollection<TeamMember>, int, FEVProject.Models.Task>(teamMem, eventId, task));
                }
                else if (description == null)
                {
                    ModelState.AddModelError("description", "Please enter description");                    
                    return View(new Tuple<ICollection<TeamMember>, int, FEVProject.Models.Task>(teamMem, eventId, task));
                }
                else
                {                    
                    task.receiver = receiver;
                    task.description = description;                    
                    _context.Tasks.Update(task);
                    _context.SaveChanges();                    
                    return RedirectToAction("EventDetail", new { id = eventId });
                }
            }            
        }
        public async Task<IActionResult> SearchAddMemToTeam(int id, string search)
        {
            int eventId = _context.Teams.Find(id).eventId;
            var teamMem = _context.TeamMembers.Where(m => m.teamId == id).ToList();
            var users = _context.Users.ToList();
            foreach (var m in teamMem)
            {
                var u = users.FirstOrDefault(a => a.username.Equals(m.username));
                if (u != null)
                {
                    users.Remove(u);
                }
            }
            if(search != null)
            {
                users = users.Where(m => m.username.Contains(search)).ToList();
            }
            return View("AddMemToTeam",new Tuple<ICollection<User>, int, int>(users, id, eventId));
        }
        public async Task<IActionResult> EventManage(string search)
        {
            var events = _context.Events.ToList();
            if (search != null)
            {
                events = events.Where(m => m.name.Contains(search)).ToList();
            }
            return View(new Tuple<ICollection<Event>>(events));
        }
        public async Task<IActionResult> AddNewEvent()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddNewEvent(AddNewEventModel model)
        {
            if(ModelState.IsValid)
            {
                Event @event = new Event();
                @event.name = model.title;
                @event.description = model.description;
                @event.done = false;
                @event.username = HttpContext.Session.GetString("id");
                _context.Events.Add(@event);
                _context.SaveChanges();
                return RedirectToAction(nameof(EventManage));
            }
            return View(model);
        }
        public async Task<IActionResult> DoneEvent(int eventId)
        {
            var ev = _context.Events.Find(eventId);
            if (ev.done)
            {                
                ev.done = false;
            }
            else
            {                
                ev.done = true;
            }
            _context.Events.Update(ev);
            _context.SaveChanges();
            return RedirectToAction(nameof(EventManage));
        }
        public async Task<IActionResult> DeleteEvent(int eventId)
        {            
            var teams = _context.Teams.Where(m => m.eventId == eventId).ToList();
            foreach (var t in teams)
            {
                var tasks = _context.Tasks.Where(m => m.teamId == t.teamId).ToList();
                foreach(var ta in tasks)
                {
                    _context.Comments.RemoveRange(_context.Comments.Where(m => m.taskId == ta.taskId));
                }
                _context.SaveChanges();
                _context.Tasks.RemoveRange(tasks);
                _context.TeamMembers.RemoveRange(_context.TeamMembers.Where(m => m.teamId == t.teamId));                
            }
            _context.SaveChanges();
            _context.Teams.RemoveRange(teams);
            _context.SaveChanges();
            _context.Events.Remove(_context.Events.Find(eventId));
            _context.SaveChanges();
            return RedirectToAction("EventManage");
        }
        public async Task<IActionResult> EditEvent(int eventId)
        {
            var @event = _context.Events.Find(eventId);
            var teams = _context.Teams.Where(m => m.eventId == eventId).ToList();
            return View(new Tuple<ICollection<Team>, Event>(teams, @event));
        }
        [HttpPost]
        public async Task<IActionResult> EditEvent(int eventId, AddNewEventModel model)
        {
            
            if (ModelState.IsValid)
            {
                var ev = _context.Events.Find(eventId);
                ev.name = model.title;
                ev.description = model.description;
                _context.Events.Update(ev);
                _context.SaveChanges();
            }
            var @event = _context.Events.Find(eventId);
            var teams = _context.Teams.Where(m => m.eventId == eventId).ToList();
            return View(new Tuple<ICollection<Team>, Event>(teams, @event));
        }
        public async Task<IActionResult> AddNewTeam(int eventId)
        {
            return View(new Tuple<AddNewTeamModel, int>(new AddNewTeamModel(), eventId));
        }
        [HttpPost]
        public async Task<IActionResult> AddNewTeam(int eventId, AddNewTeamModel model)
        {
            if (ModelState.IsValid)
            {
                Team newTeam = new Team();
                newTeam.name = model.name;
                newTeam.description = model.description;
                newTeam.eventId = eventId;
                _context.Teams.Add(newTeam);
                _context.SaveChanges();
                return RedirectToAction("EditEvent", new { eventId = eventId});
            }
            return View(new Tuple<AddNewTeamModel, int>(model, eventId));
        }
        public async Task<IActionResult> DeleteTeam(int teamId)
        {
            var team = _context.Teams.Find(teamId);
            int eventId = team.eventId;
            var tasks = _context.Tasks.Where(m => m.teamId == team.teamId).ToList();
            foreach (var ta in tasks)
            {
                _context.Comments.RemoveRange(_context.Comments.Where(m => m.taskId == ta.taskId));
            }
            _context.SaveChanges();
            _context.Tasks.RemoveRange(tasks);
            _context.TeamMembers.RemoveRange(_context.TeamMembers.Where(m => m.teamId == team.teamId));            
            _context.SaveChanges();
            _context.Teams.Remove(team);
            _context.SaveChanges();
            return RedirectToAction("EditEvent", new { eventId = eventId });
        }
        public async Task<IActionResult> EditTeam(int teamId)
        {
            var team = _context.Teams.Find(teamId);
            AddNewTeamModel model = new AddNewTeamModel();
            model.name = team.name;
            model.description = team.description;
            return View(new Tuple<AddNewTeamModel, int>(model, team.teamId));
        }
        [HttpPost]
        public async Task<IActionResult> EditTeam(int teamId, AddNewTeamModel model)
        {
            if(ModelState.IsValid)
            {
                var team = _context.Teams.Find(teamId);
                team.name = model.name;
                team.description = model.description;
                _context.Teams.Update(team);
                _context.SaveChanges();
                return RedirectToAction("EditEvent", new { eventId = team.eventId });
            }
            return View(new Tuple<AddNewTeamModel, int>(model, teamId));
        }
    }
}
