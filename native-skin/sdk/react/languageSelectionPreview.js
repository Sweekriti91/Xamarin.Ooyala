'use strict';

import PropTypes from 'prop-types';

import React, { Component } from 'react';
import {
  Animated,
  Text,
  View
} from 'react-native';

import {
  UI_SIZES
} from './constants';

var Utils = require('./utils');
var styles = Utils.getStyles(require('./panels/style/languageSelectionPanelStyles.json'));

class LanguageSelectionPreview extends React.Component {
  static propTypes = {
    config: PropTypes.object,
    selectedLanguage: PropTypes.string,
    isVisible: PropTypes.bool
  };

  state = {
    height: new Animated.Value(this.props.isVisible ? UI_SIZES.CC_PREVIEW_HEIGHT: 0)
  };

  componentDidUpdate(prevProps, prevState) {
    this.state.height.setValue(this.props.isVisible ? 0 : UI_SIZES.CC_PREVIEW_HEIGHT);
    Animated.timing(this.state.height, {
      toValue: this.props.isVisible ? UI_SIZES.CC_PREVIEW_HEIGHT : 0,
      duration: 300,
      delay: 0
    }).start();
  }

  render() {
    return (
      <Animated.View style={styles.previewPanel}>
      <View style={styles.splitter} />
      <View style={styles.previewTextContainer}>
        <Text style={styles.buttonText}>{Utils.localizedString(this.props.selectedLanguage, 'CLOSED CAPTION PREVIEW', this.props.config.localizableStrings)}</Text>
        <Text style={styles.buttonText}>{Utils.localizedString(this.props.selectedLanguage, 'Sample Text', this.props.config.localizableStrings)}</Text>
      </View>
      </Animated.View>
    );
  }
}

module.exports = LanguageSelectionPreview;