import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Task } from '../../models/task.model';
import { HttpClient } from '@angular/common/http';
import { take } from 'rxjs';

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

  constructor(private formBuilder: FormBuilder, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  ngOnInit(): void {
    this.addTaskForm = this.formBuilder.group({
      newTask: ['']
    });
  }

  addTask() {
    const newDescription = this.addTaskForm.get('newTask')?.value;
    this.saveTask(newDescription);
  }

  saveTask(taskDescription: string) {
    this.http.post<Task>(this.baseUrl + 'task/AddTask?taskDescription=' + taskDescription, null)
      .pipe(take(1))
      .subscribe(result => {
        const task = new Task(result.id, taskDescription, false);
        this.pendingTasks.push(task);
        this.addTaskForm.patchValue({
          newTask: ''
        });
      })
  }

  changeStatus(task: Task) {
    if (task.isCompleted) {
      this.completedTasks = this.completedTasks.filter(x => x.id !== task.id);
      task.isCompleted = false;
      this.pendingTasks.push(task);
    } else {
      this.pendingTasks = this.pendingTasks.filter(x => x.id !== task.id);
      task.isCompleted = true;
      this.completedTasks.push(task);
    }
  }
}
