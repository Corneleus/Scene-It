export class Movie {
    MovieId: number;
    Title: string;
    Year: string;
    Rated: string;
    Released: Date;
    Runtime: string;
    Genre: string;
    Director: string;
    Writer: string;
    Actors: string;
    Plot: string;
    Language: string;
    Country: string;
    Awards: string;
    Poster: string;
    Metascore: string;
    ImdbRating: string;
    ImdbVotes: string;
    ImdbId: string;
    Type: string;
    Dvd: string;
    BoxOffice: string;
    Production: string;

    constructor(MovieId: number, Title?: string, Year?: string, Rated?: string, Released?: Date, Runtime?: string, Genre?: string, Director?: string, Writer?: string, Actors?: string,
        Plot?: string, Language?: string, Country?: string, Awards?: string, Poster?: string, Metascore?: string, ImdbRating?: string, ImdbVotes?: string, ImdbId?: string, Type?: string, 
        Dvd?: string, BoxOffice?: string, Production?: string) {
        this.MovieId = MovieId;
        this.Title = Title;
        this.Year = Year;
        this.Rated = Rated;
        this.Released = Released;
        this.Runtime = Runtime;
        this.Genre = Genre;
        this.Director = Director;
        this.Writer = Writer;
        this.Actors = Actors;
        this.Plot = Plot;
        this.Language = Language;
        this.Country = Country;
        this.Awards = Awards;
        this.Poster = Poster;
        this.Metascore = Metascore;
        this.ImdbRating = ImdbRating;
        this.ImdbVotes = ImdbVotes;
        this.ImdbId = ImdbId;
        this.Type = Type;
        this.Dvd = Dvd;
        this.BoxOffice = BoxOffice;
        this.Production = Production;
    }
}
