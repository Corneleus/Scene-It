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
    {id: 1,  name: 'Action'},
    {id: 2,  name: 'Adventure'},
    {id: 3,  name: 'Comedy'},
    {id: 4,  name: 'Drama'},
    {id: 5,  name: 'Slice of Life'},
    {id: 6,  name: 'Fantasy'},
    {id: 7,  name: 'Magic'},
    {id: 8,  name: 'Supernatural'},
    {id: 9,  name: 'Horror'},
    {id: 10, name: 'Mystery'},
    {id: 11, name: 'Psycological'},
    {id: 12, name: 'Romance'},
    {id: 13, name: 'Sci-Fi'},
    {id: 14, name: 'Magic'},
    {id: 15, name: 'Supernatural'},
    {id: 16, name: 'Cyberpunk'},
    {id: 17, name: 'Game'},
    {id: 18, name: 'Ecchi'},
    {id: 19, name: 'Demons'},
    {id: 20, name: 'Harem'},
    {id: 21, name: 'Josei'},
    {id: 22, name: 'Martial Arts'},
    {id: 23, name: 'Kids'},
    {id: 24, name: 'Historial'},
    {id: 25, name: 'Hentai'},
    {id: 26, name: 'Isekai'},
    {id: 27, name: 'Military'},
    {id: 28, name: 'Mecha'},
    {id: 29, name: 'Music'},
    {id: 30, name: 'Parody'},
    {id: 31, name: 'Police'},
    {id: 32, name: 'Post-Apocalyptic'},
    {id: 33, name: 'Reverse Harem'},
    {id: 34, name: 'School'},
    {id: 35, name: 'Seinen'},
    {id: 36, name: 'Shounen'},
    {id: 37, name: 'Shoujo'},
    {id: 38, name: 'Shoujo-ai'},
    {id: 39, name: 'Space'},
    {id: 40, name: 'Sports'},
    {id: 41, name: 'Super Powers'},
    {id: 42, name: 'Tragedy'},
    {id: 43, name: 'Vampire'},
    {id: 44, name: 'Yuri'},
    {id: 45, name: 'Yaoi'},
 

  ];
  selected = [

  ];


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


