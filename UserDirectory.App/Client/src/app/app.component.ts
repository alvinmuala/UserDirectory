import {HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgbModal, NgbModalOptions } from '@ng-bootstrap/ng-bootstrap';
import APIEndpoints from './constants/APIEndpoints';
import { ModalUpdatePostComponent } from './modal-update-post/modal-update-post.component';
import { Post } from './models/post.model';
import { PostService } from './services/post.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Client';

  modalOptions: NgbModalOptions = {
    size: 'lg'
  }

  constructor(private httpClient: HttpClient, public postService: PostService, private modalService: NgbModal){}

  ngOnInit(): void {
    this.httpClient.get<Post[]>(APIEndpoints.GET_ALL_USERS)
      .subscribe(response => {
        this.postService.allPosts = response;
      })
  }


  onClickBtnUpdatePost(post: Post){
    const modalRef = this.modalService.open(ModalUpdatePostComponent, this.modalOptions);

    modalRef.componentInstance.postToUpdate = post;
  }

}
