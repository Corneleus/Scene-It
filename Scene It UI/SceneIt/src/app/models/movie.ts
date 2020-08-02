import { StringifyOptions } from 'querystring';

export class Movie {
    Name:string;
    Genre:string;
    Year:string;
    Rated:string;

    constructor(name?:string, genre?:string, year?:string, rated?:string) {
    this.Name = name;
    this.Genre = genre;
    this.Year = year;
    this.Rated = rated;
 }

}
