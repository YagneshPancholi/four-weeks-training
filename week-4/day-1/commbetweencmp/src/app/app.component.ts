import { AfterViewInit, Component, ElementRef, ViewChild } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements AfterViewInit {
  userLoggedIn: boolean = false;
  name: string = 'yagnesh';
  imageUrl: string =
    'https://images.unsplash.com/photo-1690402007022-bc3ea0e74fef?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHx0b3BpYy1mZWVkfDJ8Q0R3dXdYSkFiRXd8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=500&q=60';
  count = 0;
  myName!: string;
  userName!: string;
  private _customerName!: string;
  @ViewChild('nameRef') nameElementRef!: ElementRef;

  ngAfterViewInit(): void {
    this.nameElementRef.nativeElement.focus();
  }

  get customerName(): string {
    return this._customerName;
  }
  set customerName(value: string) {
    this._customerName = value;
    if (value == 'Yagu') {
      alert('Hello Yagu..');
    }
  }

  incrementCount() {
    this.count++;
  }

  greetYagnesh(updatedValue: string) {
    this.userName = updatedValue;
    if (updatedValue == 'Yagnesh') {
      alert('WelcomeBack Yagu...');
    }
  }
  greet(value: string) {
    alert('hello yagensh');
  }
}
