import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ApiService } from '../service/apiService';

@Component({
  selector: 'app-form',
  templateUrl: './insert.component.html',
  styleUrls: ['./insert.component.css']
})
export class InsertComponent implements OnInit {


  form: FormGroup;

  get getNombre(): AbstractControl {
    return this.form.get('CategoryName');
  }

  get getDescripcion(): AbstractControl {
    return this.form.get('CategoryDescription');
  }

  constructor(
    private readonly formBuilder: FormBuilder,
    public service: ApiService,
    private router: Router) { }


  ngOnInit(): void {

    this.form = this.formBuilder.group({

      CategoryName: ['', Validators.required],
      CategoryDescription: ['', Validators.required],
      CategoryId: ['']


    });

  }

  submit(): void {

    this.service.insertCategory(this.form.value).subscribe(res => {
      this.router.navigate(['getlist']);
    },

      error => { alert(error) }

    );
  }


  reset(): void {
    this.form.reset();
  }


}


