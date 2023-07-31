import { Component} from '@angular/core';
import { EmailValidator } from '@angular/forms';


@Component({
  selector: 'w3pro-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent {
	signUpUsers : signUp[] = [];
	signUpObj : signUp ={
		userName :"",
		email : "",
		password: ""
	};
	loginObj : login = { 
		userName :"",
		password : ""
	};
	ngOnInit() : void{
			const localData = localStorage.getItem('signUpUsers');
			if(localData != null){
				this.signUpUsers = JSON.parse(localData);
			}
	}
	onLogin(){
			const isUserExist = this.signUpUsers.find( user => (user.userName = this.loginObj.userName) && (user.password == this.loginObj.password));
			if(isUserExist != null){
				alert('User Login Successfully...');
			}else{
				alert('Wrong user credentials...');
			}
	}
	onSignUp(){
		this.signUpUsers.push(this.signUpObj);
		localStorage.setItem('signUpUsers',JSON.stringify(this.signUpUsers));
		this.signUpObj={
			userName :"",
			email : "",
			password: ""
		};
	}
}	

export interface signUp{
	userName:string;
	email:string;
	password:string;
}
export interface login{
	userName:string;
	password:string;
}