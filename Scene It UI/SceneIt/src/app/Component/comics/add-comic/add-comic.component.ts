import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { Comic } from 'src/app/models/comic';


@Component({
  selector: 'app-add-comic',
  templateUrl: './add-comic.component.html'
})


export class AddComicComponent implements OnInit {
  closeResult: string = '';
  comics: Comic[] = [];
  title: string;

  items = [
    { id: 1,  name: 'Action' },
    { id: 2,  name: 'Adventure' },
    { id: 3,  name: 'Comedy' },
    { id: 4,  name: 'Drama' },
    { id: 5,  name: 'Slice of Life' },
    { id: 6,  name: 'Fantasy' },
    { id: 7,  name: 'Magic' },
    { id: 8,  name: 'Supernatural' },
    { id: 9,  name: 'Horror' },
    { id: 10, name: 'Mystery' },
    { id: 11, name: 'Psycological' },
    { id: 12, name: 'Romance' },
    { id: 13, name: 'Sci-Fi' },
    { id: 14, name: 'Cyberpunk' },
    { id: 15, name: 'Game' },
    { id: 16, name: 'Ecchi' },
    { id: 17, name: 'Demons' },
    { id: 18, name: 'Harem' },
    { id: 19, name: 'Josei' },
    { id: 20, name: 'Martial Arts' },
    { id: 21, name: 'Kids' },
    { id: 22, name: 'Historial' },
    { id: 23, name: 'Hentai' },
    { id: 24, name: 'Isekai' },
    { id: 25, name: 'Military' },
    { id: 26, name: 'Mecha' },
    { id: 27, name: 'Music' },
    { id: 28, name: 'Parody' },
    { id: 29, name: 'Police' },
    { id: 30, name: 'Post-Apocalyptic' },
    { id: 31, name: 'Reverse Harem' },
    { id: 32, name: 'School' },
    { id: 33, name: 'Seinen' },
    { id: 34, name: 'Shounen' },
    { id: 35, name: 'Shoujo' },
    { id: 36, name: 'Shoujo-ai' },
    { id: 37, name: 'Space' },
    { id: 38, name: 'Sports' },
    { id: 39, name: 'Super Powers' },
    { id: 40, name: 'Tragedy' },
    { id: 41, name: 'Vampire' },
    { id: 42, name: 'Yuri' },
    { id: 43, name: 'Yaoi' },


  ];
  selected = [];

  constructor(private modalService: NgbModal) { }

  ngOnInit(): void { }

  addComic(form: NgForm) {
    console.log(form);
  }

  open(content) {
    this.modalService.open(content, { ariaLabelledBy: 'modal-add-comic-title', size: 'xl', scrollable: true }).result.then((result) => {
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


