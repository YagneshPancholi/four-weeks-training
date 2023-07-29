import { Component, EventEmitter, Input, Output } from '@angular/core';
import { User } from '../hello.component';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent {

  myName:string = "yagnesh";
  @Input() name :string = '';
  @Input() tableDetails : User[] =[];
  @Output() nothing = new EventEmitter<string>;
  greetMe(text:string):void{
    this.nothing.emit(text);
  }
}
