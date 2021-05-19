import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { ApiService } from '../service/apiService';
import { Categories } from '../service/categoriesModel';

@Component({
  selector: 'app-update-form',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {

  public form: FormGroup;
  private subscription: Subscription;

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


    this.subscription = this.service.getCategoryId(this.route.snapshot.params['id']).subscribe(
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

  ngOnDestroy() {

    this.subscription.unsubscribe();
  }

  submit(): void {
    console.log(this.form.value);

    this.subscription = this.service.updateCategory(this.category.CategoryId, this.form.value).subscribe(res => {
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

