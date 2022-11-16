import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';

import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { PostCreateUpdateDTO } from '../models/post-create-update-dto.model';
import { PostService } from '../services/post.service';
import { Post } from '../models/post.model';

@Component({
  selector: 'app-modal-update-post',
  templateUrl: './modal-update-post.component.html',
  styleUrls: ['./modal-update-post.component.css']
})
export class ModalUpdatePostComponent implements OnInit {
  form!: FormGroup;
  postToUpdate!: Post;

  updateSuccessful: boolean = false;
  updateFailed: boolean = false;

  constructor(public fb: FormBuilder, private httpClient: HttpClient, public activeModal: NgbActiveModal, private postService: PostService) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      firstName: [this.postToUpdate.firstName],
      lastName: [this.postToUpdate.lastName],
      dateOfBirth: [this.postToUpdate.dateOfBirth],
      emailAddress: [this.postToUpdate.emailAddress],
      address: [this.postToUpdate.address],
      city:  [this.postToUpdate.city],
      country:  [this.postToUpdate.country],
      zipCode:  [this.postToUpdate.zipCode],
       
    });

    this.form.controls['id'].disable();
  }

}

