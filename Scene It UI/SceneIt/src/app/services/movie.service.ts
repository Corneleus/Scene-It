import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Movie } from '../models/movie';
import { Observable, ObservableLike } from 'rxjs';
import { map } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class MovieService {

  apiKey: string = "988bc720"
  

  constructor(private http: HttpClient) {}

  getMovies(): Observable<Movie[]> {
    return this.http.get(`/api/movies`).pipe(map(x => x as Movie[]));
  }
  // this is the same as the getmovies however dosnt require use of the pipe method called type transformation
  addMovie(movie: Movie): Observable<string> {
    return this.http.post<string>(`/api/movies/add`, movie);
  }

  searchOmdbApi(query: string): Observable<Movie[]> {
    return this.http.get(`http://www.omdbapi.com/?apikey=${this.apiKey}&s=${query}`).pipe(map(x => {
      let movies: Movie[] = []; 
        x['Search'].forEach(obj => {
        movies.push(this.convertJsonToMovie(obj));
      });
      return movies;
    }));
  }

  getOmdbMovieById(id: string): Observable<Movie> {
    return this.http.get(`http://www.omdbapi.com/?apikey=${this.apiKey}&s=${id}`).pipe(map(x => {
      return this.convertJsonToMovie(x);
    }));
  }


  private convertJsonToMovie(obj: object): Movie {
    let movie: Movie = new Movie(0, obj['Title'], obj['Year'], obj['Rated'], obj['Released'], obj['Runtime'], obj['Genre'], obj['Director'], obj['Writer'], obj['Actors'], obj['Plot'], 
    obj['Language'], obj['Country'], obj['Awards'], obj['Poster'], obj['Metascore'], obj['imdbRating'], obj['imdbVotes'], obj['imdbID'], obj['Type'], obj['Dvd'], obj['BoxOffice'], 
    obj['Production']);    
    return movie;
  }
}

