import { Component, OnInit } from '@angular/core';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { Comic } from 'src/app/models/comic';

@Component({
  selector: 'app-add-comic',
  templateUrl: './add-comic.component.html'
})
export class AddComicComponent implements OnInit {
  closeResult: string = '';
  comics: Comic[] = [];

  constructor(private modalService: NgbModal) { }

  ngOnInit(): void {
  }

  addComic(){

  }

  open(content) {
    this.modalService.open(content, { ariaLabelledBy: 'modal-add-comic-title', size: 'xl', scrollable: true}).result.then((result) => {
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
