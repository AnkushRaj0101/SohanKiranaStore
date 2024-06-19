import { Component } from '@angular/core';

@Component({
  selector: 'app-carousel',
  templateUrl: './carousel.component.html',
  styleUrls: ['./carousel.component.scss']
})
export class CarouselComponent {
  myInterval = 10000;
  activeSlideIndex = 0;
  slides: { image: string; text?: string }[] = [
    { image: 'assets/Images/Carousel3.jpg', text: 'Beautiful nature image 3' },
    { image: 'assets/Images/Carousel4.jpg', text: 'Beautiful nature image 2' },
    { image: 'assets/Images/Carousel5.jpg', text: 'Beautiful nature image 1' }
  ];

  slideChangeMessage = '';
  log(event: number) {
    // simple hack for expression has been changed error
    setTimeout(() => {
      this.slideChangeMessage = `Slide has been switched: ${event}`;
    });
  }
}
