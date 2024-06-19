import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WhySohanKiranaComponent } from './why-sohan-kirana.component';

describe('WhySohanKiranaComponent', () => {
  let component: WhySohanKiranaComponent;
  let fixture: ComponentFixture<WhySohanKiranaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WhySohanKiranaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WhySohanKiranaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
