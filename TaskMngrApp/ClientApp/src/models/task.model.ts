export class Task {
  id!: number;
  description: string;
  isCompleted: boolean;

  constructor(description: string, isCompleted: boolean) {
    this.description = description;
    this.isCompleted = isCompleted;
  }
}
