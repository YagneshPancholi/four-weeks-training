import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiServiceService } from 'src/Services/api-service.service';
import { Post } from 'src/post/post.component';

@Component({
  selector: 'day4-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  posts : Array<Post> = [];
  //  : Post[] = [];
  constructor(private postService:ApiServiceService){}
  ngOnInit(){
      this.postService.getPosts().subscribe((p) =>{
      // this.posts = this.posts.concat([],p);
      this.posts = p;
      //  console.log(p);
      //  console.log(p.length);
      //  console.log(this.posts.length);
    });
  }

  // postService.createPost(newPost).subscribe((post: Post) =>{
  //   console.log(post)
  // });
}
const newPost:Post = {
  userId : 5,
  body : "This is new Post",
  title : 'Ahh, NewPost'
};