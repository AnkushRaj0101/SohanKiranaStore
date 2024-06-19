import { Component } from '@angular/core';

@Component({
  selector: 'app-testimonial',
  templateUrl: './testimonial.component.html',
  styleUrls: ['./testimonial.component.scss']
})
export class TestimonialComponent {
 
    testimonials = [
        { name: 'John Doe', avatar: 'assets/Images/People1.jpeg', review: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.' },
        { name: 'Jane Smith', avatar: 'assets/Images/people2.jpeg', review: 'Quisque euismod, nisi vel consectetur blandit, enim purus efficitur nunc.' },
        { name: 'Mike Johnson', avatar: 'assets/Images/people3.jpeg', review: 'Sed cursus, libero ac ullamcorper consectetur, erat nunc consequat mi.' },
        { name: 'Emily Davis', avatar: 'assets/Images/people4.jpeg', review: 'Integer lacinia quam at lectus vulputate, ut sagittis massa varius.' },
        { name: 'Sarah Brown', avatar: 'assets/Images/people5.jpeg', review: 'Mauris interdum orci sit amet nisl vestibulum, eget suscipit nisi hendrerit.' }
    ];

    displayedTestimonials: any[] = [];

    currentIndex = 0;

    constructor() { }

    ngOnInit(): void {
        this.updateDisplayedTestimonials();
    }

    slide(direction: 'left' | 'right'): void {
        if (direction === 'left') {
            this.currentIndex = (this.currentIndex - 1 + this.testimonials.length) % this.testimonials.length;
        } else {
            this.currentIndex = (this.currentIndex + 1) % this.testimonials.length;
        }
        this.updateDisplayedTestimonials();
    }

    updateDisplayedTestimonials(): void {
        const testimonialsCount = this.testimonials.length;
        this.displayedTestimonials = [
            this.testimonials[(this.currentIndex - 1 + testimonialsCount) % testimonialsCount],
            this.testimonials[this.currentIndex],
            this.testimonials[(this.currentIndex + 1) % testimonialsCount]
        ];
    }

}
