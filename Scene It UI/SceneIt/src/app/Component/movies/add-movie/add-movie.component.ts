import { Component, OnInit } from '@angular/core';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-add-movie',
  templateUrl: './add-movie.component.html',
  styleUrls: ['./add-movie.component.scss']
})
export class AddMovieComponent implements OnInit {
  selectedMovie:any;
  closeResult = '';

  constructor(private modalService: NgbModal) {}
  
  ngOnInit(): void {
  } 

  open(content) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-add-movie-title', size: 'xl', scrollable: true}).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }

  selectMovie(movie:any) {
     this.selectedMovie=movie;
  }

   addMovie() {
  //   this.movieService.addMovie(this.selectedMovie).subscribe(data => {
  //     this.modalService.dismissAll();  
  //   }, error => {
  //     this.modalService.dismissAll();
  //   });
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
