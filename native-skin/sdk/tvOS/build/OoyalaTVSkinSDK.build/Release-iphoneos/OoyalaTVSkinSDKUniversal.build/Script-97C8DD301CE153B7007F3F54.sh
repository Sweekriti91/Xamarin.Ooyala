#!/bin/sh
SIMULATOR_LIBRARY_PATH="${BUILD_DIR}/${CONFIGURATION}-appletvsimulator/${PROJECT_NAME}.framework/${PROJECT_NAME}" &&
DEVICE_LIBRARY_PATH="${BUILD_DIR}/${CONFIGURATION}-appletvos/${PROJECT_NAME}.framework/${PROJECT_NAME}" &&
UNIVERSAL_LIBRARY_PATH="${BUILD_DIR}/${PROJECT_NAME}-universal.a" &&
lipo "${SIMULATOR_LIBRARY_PATH}" "${DEVICE_LIBRARY_PATH}" -create -output "${UNIVERSAL_LIBRARY_PATH}"

FRAMEWORK_PATH="${BUILD_DIR}/${PROJECT_NAME}.framework"
FRAMEWORK_HEADERS_PATH="${FRAMEWORK_PATH}/Versions/A/Headers"

# Create framework header dir
mkdir -p "${FRAMEWORK_HEADERS_PATH}"
#copy header
/bin/cp -a "${BUILD_DIR}/${CONFIGURATION}-appletvos/${PROJECT_NAME}.framework/Headers/" "${FRAMEWORK_HEADERS_PATH}"

#copy fat libary
cp "${UNIVERSAL_LIBRARY_PATH}" "${FRAMEWORK_PATH}/Versions/A/${PROJECT_NAME}"

#create the required symlinks
/bin/ln -sfh A "${FRAMEWORK_PATH}/Versions/Current"
/bin/ln -sfh Versions/Current/Headers "${FRAMEWORK_PATH}/Headers"
/bin/ln -sfh "Versions/Current/${PROJECT_NAME}" "${FRAMEWORK_PATH}/${PROJECT_NAME}"

