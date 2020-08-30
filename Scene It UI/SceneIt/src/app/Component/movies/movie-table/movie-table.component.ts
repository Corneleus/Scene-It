import { Component, OnInit, Input } from '@angular/core';
import { Movie } from 'src/app/models/movie';
import { MovieService } from 'src/app/services/movie.service';

@Component({
  selector: 'app-movie-table',
  templateUrl: './movie-table.component.html',
})
export class MovieTableComponent implements OnInit {

  @Input() movies: Movie[];

  constructor() { }

  ngOnInit(): void {}

  

}
