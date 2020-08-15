import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MoviesComponent } from './Component/movies/movies.component';
import { HomeComponent } from './Component/home/home.component';
import { TableComponent } from './Common/table/table.component';
import { ComicsComponent } from './Component/comics/comics.component';
import { NovelsComponent } from './Component/novels/novels.component';
import { SeriesComponent } from './Component/series/series.component';
import { GamesComponent } from './Component/games/games.component';
 



const routes: Routes = [
  { path: 'movies', component: MoviesComponent },
  { path: 'comics', component: ComicsComponent },
  { path: 'novels', component: NovelsComponent },
  { path: 'series', component: SeriesComponent },
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'table', component: TableComponent},
  { path: 'games', component: GamesComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
