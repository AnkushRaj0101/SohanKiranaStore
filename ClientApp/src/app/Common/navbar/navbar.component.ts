import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent {
  isLogin: boolean = true;

  constructor(private router: Router) {}

  logout() {
    // Implement your logout logic here
    this.isLogin = false;
    this.router.navigate(['/']); // Redirect to home after logout
  }

}
