---
title: Roaring Platform Overview
vendor: Roaring
owner: Product Director
reviewer: Solution Architect
status: Active
version: 1.0
last_reviewed: 2026-07-14
category: Platform
domain: Roaring
audience:
  - Product Director
  - Discovery Agent
  - Solution Architect
  - Product Marketing
source_of_truth:
  - Official Roaring documentation and agreements
related_documents:
  - README.md
  - 03-API-CATALOG.md
  - 09-KNOWN-LIMITATIONS.md
---

# Platform overview

Roaring is treated in Product OS as an external provider of company, person and compliance-related data services. Exact services, countries and data rights vary by API product and customer agreement.

## Business use cases

Potential use cases include:

- finding and validating organizations or people during onboarding
- enriching CRM records with authoritative attributes
- retrieving ownership, management or signatory information
- supporting KYC and AML processes
- monitoring entities for relevant changes
- reducing manual lookup and duplicate data entry
- improving data quality in operational systems

## Product boundary

A Roaring-based product should provide workflow value rather than expose raw data only. Examples include guided onboarding, controlled CRM enrichment, risk review, monitoring queues and audit-ready decision support.

## Core principles

- Licence and purpose determine which data may be requested and stored.
- The latest response is not automatically permanent master data.
- Sensitive person and compliance data requires stricter access and retention controls.
- Vendor availability, customer entitlement and technical implementation are separate concerns.
- Products must degrade safely when the vendor service is unavailable.

## Validation required

Before committing scope, confirm the contracted APIs, environments, country coverage, identifiers, rate limits, response schemas, update frequency, storage rights and support model.