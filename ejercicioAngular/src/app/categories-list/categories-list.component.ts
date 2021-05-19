import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ApiService } from '../service/apiService';
import { Categories } from '../service/categoriesModel';


@Component({
  selector: 'app-categories-list',
  templateUrl: './categories-list.component.html',
  styleUrls: ['./categories-list.component.css']
})
export class CategoriesListComponent implements OnInit {

  categoriesList: Categories[];

  constructor(public service: ApiService,
    private router: Router) { }


  ngOnInit() {

    this.service.getList().subscribe(
      data => {
        this.categoriesList = data;
      },
      error => {
        console.log(error);
      });
  }



  update(categoryId: any) {

    this.router.navigate(['update', categoryId]);

  }

  delete(categoryId: number): void {

    if (confirm("Confirme para eliminar")) {

      this.service.deleteCategory(categoryId).subscribe(res => {

        this.ngOnInit();
        alert("Categoria eliminada");

      },
      );
    }
  }



}
