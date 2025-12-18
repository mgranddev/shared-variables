# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Changed

- `package.json` tab size changed from 4 to 2.
- `repository.url` in `package.json` changed to SSH.
- Package moved to `/package`.

### Removed

- `files` removed from `package.json`.
- Removed GitHub Actions workflow.

## [0.3.0] - 2025-11-25

### Added

- Package publishing support to `package.json`.
- GitHub workflow for publishing to the GitHub npm registry.

## [0.2.0] - 2025-10-24

### Added

- Dependency on `com.kylewbanks.scenerefattribute`.
- `CHANGELOG.md`.
- `README.md`.

### Changed

- Renamed the create asset menu folder to "Shared Variables".
- Odin Inspector is now optional.
- Renamed `value` to `localVariable` on `SharedVariableReference`.
- Renamed `variable` to `sharedVariable` on `SharedVariableReference`.

## [0.1.0] - 2025-10-19

### Added

- This is the first published version.
