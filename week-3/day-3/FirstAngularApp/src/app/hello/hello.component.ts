import { Component } from '@angular/core';
  

@Component({
  selector: 'app-hello',
  templateUrl: './hello.component.html',
  styleUrls: ['./hello.component.css']
})


export class HelloComponent {
        name:string = "yagnesh";
        age:number = 21;
        hideAge:boolean = false;
        Toggle(){
          this.hideAge = !this.hideAge;
        }
        users : User[] = [{
          Name :  "Yagnesh",
          Age :  21,
          Email :  "yagnesh@gmail.com"
          },
          {
            Name : "Yagu",
            Age :  22,
            Email :  "yagu@gmail.com"
          },
          {
            Name : "Kunal",
            Age :  23,
            Email :  "kunal@gmail.com"
          }
          ];
}

export interface User{
  Name:string;
  Age:number;
  Email:string;
}
