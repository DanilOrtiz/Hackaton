import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SolicitanteFrmComponent } from './solicitante-frm.component';

describe('SolicitanteFrmComponent', () => {
  let component: SolicitanteFrmComponent;
  let fixture: ComponentFixture<SolicitanteFrmComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SolicitanteFrmComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SolicitanteFrmComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
