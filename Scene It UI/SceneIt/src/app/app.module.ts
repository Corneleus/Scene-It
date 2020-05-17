import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './Component/home/home.component';
import { HeaderComponent } from './Common/header/header.component';
import { FooterComponent } from './Common/footer/footer.component';
import { MoviesComponent } from './Component/movies/movies.component';
import { MovieDetailsComponent } from './Component/Movies/movie-details/movie-details.component';
import { AddMovieComponent } from './Component/Movies/add-movie/add-movie.component';
import { EditMovieComponent } from './Component/Movies/edit-movie/edit-movie.component';
import { DeleteComponent } from './Common/delete/delete.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    MoviesComponent,
    MovieDetailsComponent,
    AddMovieComponent,
    EditMovieComponent,
    DeleteComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
