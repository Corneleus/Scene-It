import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './Component/home/home.component';
import { HeaderComponent } from './Common/header/header.component';
import { FooterComponent } from './Common/footer/footer.component';
import { MoviesComponent } from './Component/movies/movies.component';
import { MovieDetailsComponent } from './Component/movies/movie-details/movie-details.component';
import { AddMovieComponent } from './Component/movies/add-movie/add-movie.component';
import { EditMovieComponent } from './Component/movies/edit-movie/edit-movie.component';
import { DeleteComponent } from './Common/delete/delete.component';
import { TableComponent } from './Common/table/table.component';
import { MovieTableComponent } from './Component/movies/movie-table/movie-table.component';
import { ComicsComponent } from './Component/comics/comics.component';
import { NovelsComponent } from './Component/novels/novels.component';
import { SeriesComponent } from './Component/series/series.component';

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
    DeleteComponent,
    TableComponent,
    MovieTableComponent,
    ComicsComponent,
    NovelsComponent,
    SeriesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
