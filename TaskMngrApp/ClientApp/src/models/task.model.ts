export class Task {
  id: number;
  description: string;
  isCompleted: boolean;

  constructor(id: number, description: string, isCompleted: boolean) {
    this.id = id;
    this.description = description;
    this.isCompleted = isCompleted;
  }
}
