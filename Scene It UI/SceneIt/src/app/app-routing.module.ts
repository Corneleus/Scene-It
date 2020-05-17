import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MoviesComponent } from './Component/movies/movies.component';
import { HomeComponent } from './Component/home/home.component';
 



const routes: Routes = [
  { path: 'movies', component: MoviesComponent },
  { path: '', component: HomeComponent, pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
