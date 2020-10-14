import { Component, OnInit } from '@angular/core';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-add-comic',
  templateUrl: './add-comic.component.html'
})
export class AddComicComponent implements OnInit {
  closeResult: string = '';

  constructor(private modalService: NgbModal) { }

  ngOnInit(): void {
  }

  addComic(){

  }

  open(content) {
    this.modalService.open(content, { ariaLabelledBy: 'modal-add-movie-title', size: 'xl', scrollable: true }).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
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
