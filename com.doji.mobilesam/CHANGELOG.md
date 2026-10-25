# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [2.0.0] - Unreleased

### Changed

- Models come from the Hugging Face repository `julienkay/sentis-MobileSAM` through AI Model Hub (`tools.doji.hf-hub`). The package no longer contains model files. Include the models in `Window > AI Model Hub`.
- Requires Unity 6000.3 or later. Uses Inference Engine 2.6.1 (`com.unity.ai.inference`) instead of Sentis 2.1.
- `Encoder` and `Decoder` are the loaded models. Changing `Backend` reuses them instead of loading them again.

### Added

- `MobileSAM.CreateAsync` loads the models on every platform, also when builds download models at runtime.
- A constructor that takes an encoder and a decoder model you loaded yourself.

### Fixed

- `Dispose` no longer throws when no image was set.
- The mask RenderTexture is created with random write enabled.

## [1.0.1] - 2024-10-07

### Changed

- Updated Sentis dependency to 2.1.0

## [1.0.0] - 2024-09-14

- Initial Release