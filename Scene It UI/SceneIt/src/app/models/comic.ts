import { generate } from 'rxjs';

export class Comic{
    ComicId: number;
    Title: string;
    AltTitle: string;
    Author: string;
    Artist: string;
    Genre: string;    
    OrigonalLanguage: string;
    Status: string;
    LatestRelease: number;
    CurrentChapter: number;
    Description: string;


    constructor(ComicId: number, Title: string, AltTitle: string, Author: string, Artist: string, Genre: string, OrigonalLanguage: string, Status: string, 
        LatestRelease: number, CurrentChapter: number, Description: string) {
            this.ComicId = ComicId;
            this.Title = Title;
            this.AltTitle = AltTitle;
            this.Author = Author;
            this.Artist = Artist;
            this.Genre = Genre;
            this.OrigonalLanguage = OrigonalLanguage;
            this.Status = Status;
            this.LatestRelease = LatestRelease;
            this.CurrentChapter = CurrentChapter;
            this.Description = Description;
    }

}