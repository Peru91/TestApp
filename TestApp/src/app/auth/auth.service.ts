import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { User } from '../user';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  serverUrl = 'http://localhost:59629/api/'; // WebApi Url
  errorData: {};

  isLoggedIn = false;

  constructor(private http: HttpClient) { }

  redirectUrl: string;

  login(username: string, password: string) {
    let user = new User();
    user.Email= username;
    
    console.log(password);
    var utf8 = unescape(encodeURIComponent(password));
    var arr = [];
    for (var i = 0; i < utf8.length; i++) {
        arr.push(utf8.charCodeAt(i));
    }
    user.Password= arr;
    let headers = new HttpHeaders({
      'Content-Type': 'application/json'});
  let options = { headers: headers }; 
    let body = JSON.stringify(user);
    return this.http.post<any>(`${this.serverUrl}Account/login`, body,options)
    .pipe(map(user => {
        if (user) {
          debugger;
          localStorage.setItem('currentUser', JSON.stringify(user));
          this.isLoggedIn = true;
        }
      }),
      catchError(this.handleError)
    );
  }

  getAuthorizationToken() {
    const currentUser = JSON.parse(localStorage.getItem('currentUser'));
    return currentUser.token;
  }

  logout() {
    localStorage.removeItem('currentUser');
    this.isLoggedIn = false;
  }

  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {

      // A client-side or network error occurred. Handle it accordingly.

      console.error('An error occurred:', error.error.message);
    } else {

      // The backend returned an unsuccessful response code.

      // The response body may contain clues as to what went wrong.

      console.error(`Backend returned code ${error.status}, ` + `body was: ${error.error}`);
    }

    // return an observable with a user-facing error message

    this.errorData = {
      errorTitle: 'Oops! Request for document failed',
      errorDesc: 'Something bad happened. Please try again later.'
    };
    return throwError(this.errorData);
  }
}