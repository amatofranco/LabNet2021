import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ApiService } from '../service/apiService';
import { Categories } from '../service/categoriesModel';

@Component({
  selector: 'app-update-form',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {

  form: FormGroup;

  get getNombre(): AbstractControl {
    return this.form.get('CategoryName');
  }

  get getDescripcion(): AbstractControl {
    return this.form.get('CategoryDescription');
  }



  constructor(
    public service: ApiService,
    private router: Router,
    private route: ActivatedRoute,
    private category: Categories,
    private readonly formBuilder: FormBuilder,

  ) { }


  ngOnInit(): void {


    this.service.getCategoryId(this.route.snapshot.params['id']).subscribe(
      category => {
        this.category = category;
        this.loadForm();
      },
      error => {
        alert(error);
      });
  }

  loadForm(): void {
    this.form = this.formBuilder.group({

      CategoryName: [this.category.CategoryName, Validators.required],
      CategoryDescription: [this.category.CategoryDescription, Validators.required],
      CategoryId: [this.category.CategoryId]


    });
  }

  submit(): void {
    console.log(this.form.value);

    this.service.updateCategory(this.category.CategoryId, this.form.value).subscribe(res => {
      console.log('Categoria actualizada!');
      this.router.navigate(['getlist']);
    },
      error => { alert(error) }
    );

  }

  reset(): void {
    this.form.reset();
  }


}

