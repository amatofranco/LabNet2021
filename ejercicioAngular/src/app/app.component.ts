import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ejercicioAngular';


constructor(private router: Router){}

 getList(){
   this.router.navigate(['getlist']);   
 }

 insert(){
  this.router.navigate(['insert']);   
}



}
