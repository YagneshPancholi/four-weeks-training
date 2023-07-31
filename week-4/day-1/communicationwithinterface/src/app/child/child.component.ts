import { Component } from '@angular/core';
import { InteractionService } from '../interaction.service';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css'],
})
export class ChildComponent {
  constructor(private _interactionService: InteractionService) {}
  ngOnInit() {
    this._interactionService.teacherMessage$.subscribe((message) => {
      if (message.startsWith('Good Morning')) {
        alert('good morning, Teacher');
      } else if (message.startsWith('Well Done')) {
        alert('Thank You Teacher');
      }
    });
  }
}
