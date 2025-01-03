name: Submit new preset
about: Share your Edge policy with the community
title: New preset
labels: preset
assignees: beeradmoore
body:
  - type: markdown
    attributes:
      value: |
        Thanks for submitting your preset. Please be aware that not every preset will make it into EdgeTweaker, specifically those with non-standard customisations.
  - type: input
    id: preset_name
    attributes:
      label: Preset name
      description: Please name your preset. Your username is more than ok to use.
      placeholder: My preset
    validations:
      required: true
  - type: input
    id: preset_description
    attributes:
      label: Description
      description: Please provide a short description of your preset
      placeholder: Disables ads, enables greatness
    validations:
      required: true
  - type: textarea
    id: preset_json
    attributes:
      label: Preset json
      description: Formatted json of your preset
      placeholder: |
        json goes here
	  render: json
    validations:
      required: true