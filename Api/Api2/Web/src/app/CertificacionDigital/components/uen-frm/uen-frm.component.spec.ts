import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UenFrmComponent } from './uen-frm.component';

describe('UenFrmComponent', () => {
  let component: UenFrmComponent;
  let fixture: ComponentFixture<UenFrmComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UenFrmComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UenFrmComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
