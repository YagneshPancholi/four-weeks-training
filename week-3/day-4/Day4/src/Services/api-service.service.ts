import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Post } from 'src/post/post.component';

@Injectable({
  providedIn: 'root'
})
export class ApiServiceService {
  private base_url = 'https://jsonplaceholder.typicode.com';
  constructor(private http: HttpClient) { }

  getPosts(){
    return this.http.get<Post[]>(`${this.base_url}/posts`);
  }
  createPost(data:Post){
    return this.http.post<Post>(`${this.base_url}/posts`, data);
  }
  updatePost(id: number, data: Post){
    return this.http.put<Post>(`${this.base_url}/posts/${id}`, data);
  }
  deletePost(id: number){
      return this.http.delete<Post>(`${this.base_url}/posts/${id}`);
  }
}
