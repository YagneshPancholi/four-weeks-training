import { Component } from '@angular/core';

@Component({
  selector: 'day4-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})

export class PostComponent {

}
export interface Post{
  userId : number ;
  title : string;
  body : string;
}