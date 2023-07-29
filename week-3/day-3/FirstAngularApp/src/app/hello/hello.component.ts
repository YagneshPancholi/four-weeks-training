import { Component } from '@angular/core';
import { TableServicesService } from './Services/table-services.service';
  

@Component({
  selector: 'app-hello',
  templateUrl: './hello.component.html',
  styleUrls: ['./hello.component.css']
})


export class HelloComponent {
  
  constructor(private service:TableServicesService) {
    
  }
        mynewname:string = this.service.getName();
        name:string = "yagnesh";
        age:number = 21;
        hideAge:boolean = false;
        textToShow:string = '';
        Toggle(){
          this.hideAge = !this.hideAge;
        }
        nothing(text:string){
          this.textToShow =  text;
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
