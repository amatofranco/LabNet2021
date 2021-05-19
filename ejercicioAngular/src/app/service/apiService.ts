import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Categories } from './categoriesModel';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { stringify } from '@angular/compiler/src/util';


@Injectable({
  providedIn: 'root'
})

export class ApiService {

  private readonly url = "http://localhost:55147/api/Categories";

  constructor(private http: HttpClient) {
  }


  getList(): Observable<Categories[]> {
    return this.http.get<Categories[]>(this.url)
      .pipe(catchError(this.errorHandler));
  }

  insertCategory(category: Categories): Observable<Categories> {
    return this.http.post<Categories>(this.url, category)
      .pipe(catchError(this.errorHandler));
  }

  deleteCategory(categoryId: number): Observable<Categories> {
    return this.http.delete<Categories>(`${this.url}/${categoryId}`)
      .pipe(catchError(this.errorHandler));
  }

  getCategoryId(categoryId: number): Observable<Categories> {
    return this.http.get<Categories>(`${this.url}/${categoryId}`)
      .pipe(catchError(this.errorHandler));
  }

  updateCategory(categoryId: number, category: Categories): Observable<Categories> {
    return this.http.put<Categories>(`${this.url}/${categoryId}`, category)
      .pipe(catchError(this.errorHandler));
  }


  errorHandler(error: HttpErrorResponse) {

    let errormessage: string;


    switch (error.status) {

      case 400:

        errormessage = "Error en la validación de datos. Intente nuevamente";
        break;

      case 404:
        errormessage = "Error en el servidor. Intente nuevamente";
        break;

      case 409:

        errormessage = "La categoria no puede eliminarse al estar relacionada con otras tablas";
        break;

      default:

        errormessage = "Se produjo un error. Pruebe nuevamente";
        break;

    }

    // return an observable with a user-facing error message
    return throwError(errormessage);

  }


  ngOnInit(): void {

    this.getList();

  }


}
