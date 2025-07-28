using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TodoApi.BusinessLayer;
using TodoApi.Entities;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemsController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskItemsController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public ActionResult<List<TaskItem>> GetTask()
        {
            return _taskService.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<TaskItem> GetTaskItem(long id)
        {
            var task = _taskService.GetById(id);
            if (task == null) return NotFound();
            return task;
        }

        [HttpPost]
        public ActionResult<TaskItem> PostTaskItem(TaskItem taskItem)
        {
            _taskService.Add(taskItem);
            return CreatedAtAction(nameof(GetTaskItem), new { id = taskItem.Id }, taskItem);
        }

        [HttpPut("{id}")]
        public IActionResult PutTaskItem(long id, TaskItem taskItem)
        {
            if (id != taskItem.Id) return BadRequest();
            _taskService.Update(taskItem);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTaskItem(long id)
        {
            _taskService.Delete(id);
            return NoContent();
        }
    }
}
