import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Movie } from '../models/movie';
import { Observable} from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root'
})
export class MovieService {
  headers: HttpHeaders = new HttpHeaders();
  apiKey: string = "988bc720";

  constructor(private http: HttpClient) {
    this.headers.append('Content-Type', 'application/json');
  }

  getMovies(): Observable<Movie[]> {
    return this.http.get<Movie[]>(`${environment.api}api/movies`, { headers: this.headers });
  }
  // this is the same as the getmovies however dosnt require use of the pipe method called type transformation
  addMovie(movie: Movie): Observable<string> {
    return this.http.post<string>(`${environment.api}api/movies/add`, movie, { headers: this.headers });
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
    return this.http.get(`http://www.omdbapi.com/?apikey=${this.apiKey}&i=${id}`).pipe(map(x => {
      return this.convertJsonToMovie(x);
    }));
  }


  private convertJsonToMovie(obj: object): Movie {
    let movie: Movie = new Movie(0, obj['Title'], obj['Year'], obj['Rated'], new Date(obj['Released']), obj['Runtime'], obj['Genre'], obj['Director'], obj['Writer'], obj['Actors'], obj['Plot'], 
    obj['Language'], obj['Country'], obj['Awards'], obj['Poster'], obj['Metascore'], obj['imdbRating'], obj['imdbVotes'], obj['imdbID'], obj['Type'], obj['Dvd'], obj['BoxOffice'], 
    obj['Production']);    
    return movie;
  }
}

