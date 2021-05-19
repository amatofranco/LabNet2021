import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { ApiService } from '../service/apiService';
import { Categories } from '../service/categoriesModel';
import {MatDialogModule} from '@angular/material/dialog';

@Component({
  selector: 'app-categories-list',
  templateUrl: './categories-list.component.html',
  styleUrls: ['./categories-list.component.css']
})
export class CategoriesListComponent implements OnInit {

  public categoriesList: Categories[];
  private subscription: Subscription;

  constructor(public service: ApiService,
    private router: Router) { }


  ngOnInit() {

    this.subscription = this.service.getList().subscribe(
      data => {
        this.categoriesList = data;
      },
      error => {
        alert(error);
      });
  }

  ngOnDestroy(){

    this.subscription.unsubscribe();
  }



  update(categoryId: any) {

    this.router.navigate(['update', categoryId]);

  }

  delete(categoryId: number): void {

    if (confirm("Confirme para eliminar")) {

      this.subscription = this.service.deleteCategory(categoryId).subscribe(res => {

        this.ngOnInit();
        alert("Categoria eliminada");

      },

      error => {
        alert(error);
      });
    }
  }



}
