import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
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
  addTaskForm!: FormGroup;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.addTaskForm = this.formBuilder.group({
      newTask: ['']
    });
  }

  addTask() {
    const task = new Task(this.addTaskForm.get('newTask')?.value, false);
    this.pendingTasks.push(task);
    this.addTaskForm.patchValue({
      newTask: ''
    });
  }
}
