import { Component, OnInit } from '@angular/core';
import { Movie } from 'src/app/models/movie';

@Component({
  selector: 'app-movie-table',
  templateUrl: './movie-table.component.html',
  styleUrls: ['./movie-table.component.scss']
})
export class MovieTableComponent implements OnInit {

  movies: Movie[] = [
    // new Movie(0,'Iorn Man','Action, Adventure, Sci-Fi', '2008', 'PG-13' ),
    // new Movie(0,'The Mask','Action, Comedy, Crime', '1994', 'PG-13' ),
    // new Movie(0,'Star Wars: Episode IV - A New Hope','Action, Adventure, Fantasy', '1977', 'PG' ),
    // new Movie(0,'Schindler\'s List','Biography, Drama, History', '1993', 'R' ),
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
