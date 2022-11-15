import {HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Post } from './models/post.model';
import { PostService } from './services/post.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Client';

  constructor(private httpClient: HttpClient, public postService: PostService){}

  ngOnInit(): void {
    this.httpClient.get<Post[]>('https://localhost:7048/users')
      .subscribe(response => {
        this.postService.allPosts = response;
        console.log(this.postService.allPosts);
      })
  }

}
