import { Component, Input } from '@angular/core';
import { User } from '../hello.component';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent {

  @Input() name :string = '';
  @Input() tableDetails : User[] =[];
}
