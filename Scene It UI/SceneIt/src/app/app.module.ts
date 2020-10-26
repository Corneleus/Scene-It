import { BrowserModule } from '@angular/platform-browser';
import { NgModule, NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';

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
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MovieService } from './services/movie.service';
import { FormsModule, ReactiveFormsModule, ɵNgSelectMultipleOption } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { GamesComponent } from './Component/games/games.component';
import { AddComicComponent } from './Component/comics/add-comic/add-comic.component';




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
    SeriesComponent,
    GamesComponent,
    AddComicComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    NgbModule,
    HttpClientModule,




  ],
  providers: [MovieService],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA],
})
export class AppModule { }
