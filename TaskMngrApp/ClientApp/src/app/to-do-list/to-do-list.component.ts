import { Component, OnInit } from '@angular/core';
import { Task } from '../../models/task.model';

@Component({
  selector: 'app-to-do-list',
  templateUrl: './to-do-list.component.html',
  styleUrls: ['./to-do-list.component.css']
})
export class ToDoListComponent implements OnInit {
  tasks: Array<Task> = [];
  pendingTasks: Array<Task> = [];
  completedTasks: Array<Task> = [];

  constructor() { }

  ngOnInit(): void {
    this.populateTasks();
  }

  populateTasks() {
    this.tasks = [{ id: 1, isCompleted: false, description: 'task1' },
    { id: 2, isCompleted: false, description: 'task2' },
    { id: 3, isCompleted: true, description: 'task3' }];

    this.pendingTasks = this.tasks.filter(x => x.isCompleted === false);
    this.completedTasks = this.tasks.filter(x => x.isCompleted === true);
  }
}
