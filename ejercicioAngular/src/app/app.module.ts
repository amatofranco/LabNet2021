import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule,RouterOutlet,Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { InsertComponent } from './insert/insert.component';
import { CategoriesListComponent } from './categories-list/categories-list.component';
import { CommonModule } from '@angular/common';
import { UpdateComponent } from './update/update.component';
import { Categories } from './service/categoriesModel';



const routes: Routes = [
  {path: 'getlist', component: CategoriesListComponent},
  {path: 'insert', component: InsertComponent },
  {path: 'update/:id', component: UpdateComponent }

];


@NgModule({
  declarations: [
    AppComponent,
    InsertComponent,
    CategoriesListComponent,
    UpdateComponent,

  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    HttpClientModule,
    CommonModule,
    RouterModule.forRoot(routes, {onSameUrlNavigation: 'reload'}),

  ],
  providers: [Categories],
  bootstrap: [AppComponent]
})
export class AppModule { }
