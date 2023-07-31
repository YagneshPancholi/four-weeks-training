import {
  Component,
  EventEmitter,
  Input,
  OnChanges,
  Output,
  SimpleChanges,
} from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css'],
})
export class ChildComponent implements OnChanges {
  @Output() greetEvent = new EventEmitter();
  message: string = '';
  @Input() loggedIn!: boolean;
  name: string = 'yagnesh';
  //   private _loggedIn!: boolean;
  //   get loggedIn(): boolean {
  //     return this._loggedIn;
  //   }
  //   @Input()
  //   set loggedIn(value: boolean) {
  //     this._loggedIn = value;
  //     if (value == true) {
  //       this.message = 'welcome yagu';
  //     } else {
  //       this.message = 'plz, log in first';
  //     }
  //   }
  ngOnChanges(changes: SimpleChanges): void {
    console.log(changes);
    const loggedInValue = changes['loggedIn'];
    if (loggedInValue.currentValue) {
      this.message = 'welcome back';
    } else {
      this.message = 'plz, login first';
    }
  }
  greetMe() {
    alert('hello Yagnesh');
  }
  callParentGreet() {
    this.greetEvent.emit(this.name);
  }
}
