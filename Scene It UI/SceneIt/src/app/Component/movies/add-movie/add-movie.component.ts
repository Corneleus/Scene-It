import { Component, OnInit } from '@angular/core';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { MovieService } from 'src/app/services/movie.service';
import { Movie } from 'src/app/models/movie';

@Component({
  selector: 'app-add-movie',
  templateUrl: './add-movie.component.html',
  styleUrls: ['./add-movie.component.scss']
})
export class AddMovieComponent implements OnInit {
  movies: Movie[] = [];
  selectedMovie: Movie;
  searchString: string;
  closeResult = '';

  constructor(private modalService: NgbModal, private movieService: MovieService) { }

  ngOnInit(): void {
  }

  open(content) {
    this.modalService.open(content, { ariaLabelledBy: 'modal-add-movie-title', size: 'xl', scrollable: true }).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }

  selectMovie(movie: any) {
    this.selectedMovie = movie;
  }

  addMovie() {
    this.movieService.getOmdbMovieById(this.selectedMovie.ImdbId).subscribe(movie => {
      this.movieService.addMovie(movie).subscribe(data => {
        if (data.length > 0) {
          this.modalService.dismissAll();
        }
      }, error => {
        console.log(error);
      });
    }, error => {
      console.log(error);
    });

  }

  searchOmdb(search: string): void {
    this.movieService.searchOmdbApi(search).subscribe(data => {
      this.movies = data;
    }, error => {
      console.log(error);
    });
  }

  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }

}
