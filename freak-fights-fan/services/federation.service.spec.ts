import { TestBed } from '@angular/core/testing';

import { FederationService } from './federation.service';

describe('FederationService', () => {
  let service: FederationService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FederationService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
